using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace ArithmeticAlarmClock.Model
{
	public class ArithmeticAlarmClock : IDisposable
	{
		private static ArithmeticAlarmClock _Instance;
		public static ArithmeticAlarmClock Instance {
			get {
				if (_Instance == null)
				{
					_Instance = new ArithmeticAlarmClock();
				}
				return _Instance;
			}
		}

		private ArithmeticAlarmClock() { }

		private DateTime _Limit;
		private IDisposable _Tick;
		private IDisposable _Timer;
		private CompositeDisposable _Disposables = new CompositeDisposable();

		public ReactiveProperty<TimeSpan> RemainingTime { get; private set; } = new ReactiveProperty<TimeSpan>();

		public ReactiveProperty<ArithmeticQuestion> Question { get; private set; } = new ReactiveProperty<ArithmeticQuestion>();

		public void Start(DateTime limit)
		{
			_Limit = limit;

			_Disposables.Dispose();

			_Tick = Observable
				.Timer(new TimeSpan(0, 0, 1))
				.ObserveOn(Dispatcher.CurrentDispatcher)
				.Subscribe(_ => RemainingTime.Value = _Limit - DateTime.Now)
				.AddTo(_Disposables);

			_Timer = Observable
				.Timer(_Limit - DateTime.Now)
				.Take(1)
				.ObserveOn(Dispatcher.CurrentDispatcher)
				.Subscribe(_ =>
				{
					_Disposables.Dispose();
					Question.Value = new ArithmeticQuestion();
				})
				.AddTo(_Disposables);
		}

		public void Dispose() => _Disposables.Dispose();
	}
}
