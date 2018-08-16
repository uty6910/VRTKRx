using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnButtonOneTouchEndTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onButtonOneTouchEnd;

        public void OnButtonOneTouchEnd(object sender, ControllerInteractionEventArgs e)
        {
            if (onButtonOneTouchEnd != null)
            {
                onButtonOneTouchEnd.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonOneTouchEndAsObservable()
        {
            return onButtonOneTouchEnd ?? (onButtonOneTouchEnd = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onButtonOneTouchEnd != null)
            {
                onButtonOneTouchEnd.OnCompleted();
            }
        }
    }
}