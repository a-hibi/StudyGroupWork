using ArithmeticAlarmClock.Model;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace ArithmeticAlarmClock.ViewModel
{
	public class StartViewModel : IDisposable
	{
		public ReactiveProperty<DateTime> Limit { get; private set; } = new ReactiveProperty<DateTime>();

		public ReactiveCommand StartCommand { get; private set; } 

		private CompositeDisposable _Disposables = new CompositeDisposable();

		public StartViewModel()
		{
			StartCommand = Limit
				.Select(dt => dt > DateTime.Now)
				.ObserveOn(Dispatcher.CurrentDispatcher)
				.ToReactiveCommand();

			StartCommand
				.Subscribe(() => Model.ArithmeticAlarmClock.Instance.Start(Limit.Value))
				.AddTo(_Disposables);
		}

		public void Dispose() => _Disposables.Dispose();
	}
}
