using BlazorApp1.Store.CounterUseCase;
using Fluxor;
using Microsoft.AspNetCore.Components;
using BlazorApp1.Store;

namespace BlazorApp1.Pages
{
	public partial class Counter
	{
		[Inject]
		private IState<CounterState> CounterState { get; set; }

		[Inject]
		public IDispatcher Dispatcher { get; set; }

		private void IncrementCount()
		{
			var action = new IncrementCounterAction();
			Dispatcher.Dispatch(action);
		}
	}
}
