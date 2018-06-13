using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using ArithmeticAlarmClock.Model;
using ArithmeticAlarmClock.ViewModel;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace ArithmeticAlarmClock.View
{
	public partial class StartView : Form
	{
		private CompositeDisposable disposables = new CompositeDisposable();

		public StartView()
		{
			InitializeComponent();
			datePicker.MaxDate = timePicker.MaxDate = DateTimePicker.MaximumDateTime;
			datePicker.MinDate = timePicker.MinDate = DateTime.Now;
			datePicker.Value = timePicker.Value = DateTime.Now;

			Observable
				.FromEvent<EventHandler, EventArgs>(
					h => (o, e) => h(e),
					h => datePicker.ValueChanged += h,
					h => datePicker.ValueChanged -= h
				)
				.Subscribe(_ => ViewModel.Limit.Value = datePicker.Value.Date + timePicker.Value.TimeOfDay)
				.AddTo(disposables);

			Observable
				.FromEvent<EventHandler, EventArgs>(
					h => (o, e) => h(e),
					h => timePicker.ValueChanged += h,
					h => timePicker.ValueChanged -= h
				)
				.Subscribe(_ => ViewModel.Limit.Value = datePicker.Value.Date + timePicker.Value.TimeOfDay)
				.AddTo(disposables);

			Observable
				.FromEvent<EventHandler, EventArgs>(
					h => (o, e) => h(e),
					h => button1.Click += h,
					h => button1.Click -= h
				)
				.Subscribe(_ => ViewModel.StartCommand.Execute())
				.AddTo(disposables);

			Observable
				.FromEventPattern(
					h => ViewModel.StartCommand.CanExecuteChanged += h,
					h => ViewModel.StartCommand.CanExecuteChanged -= h)
				.Subscribe(_ => button1.Enabled = ViewModel.StartCommand.CanExecute())
				.AddTo(disposables);

			Observable
				.FromEvent<FormClosedEventHandler, FormClosedEventArgs>(
					h => (o, e) => h(e),
					h => FormClosed += h,
					h => FormClosed -= h
				)
				.Subscribe(_ => disposables.Dispose())
				.AddTo(disposables);
		}

		private StartViewModel ViewModel = new StartViewModel();

		private void StartView_Load(object sender, EventArgs e)
		{

		}
	}
}
