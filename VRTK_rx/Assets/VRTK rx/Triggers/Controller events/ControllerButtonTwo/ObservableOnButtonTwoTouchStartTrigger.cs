using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnButtonTwoTouchStartTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onButtonTwoTouchStart;

        public void OnButtonTwoTouchStart(object sender, ControllerInteractionEventArgs e)
        {
            if (onButtonTwoTouchStart != null)
            {
                onButtonTwoTouchStart.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonTwoTouchStartAsObservable()
        {
            return onButtonTwoTouchStart ?? (onButtonTwoTouchStart = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onButtonTwoTouchStart != null)
            {
                onButtonTwoTouchStart.OnCompleted();
            }
        }
    }
}