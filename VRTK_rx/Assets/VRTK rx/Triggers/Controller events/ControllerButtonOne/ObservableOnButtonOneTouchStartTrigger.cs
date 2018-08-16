using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnButtonOneTouchStartTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onButtonOneTouchStart;

        public void OnButtonOneTouchStart(object sender, ControllerInteractionEventArgs e)
        {
            if (onButtonOneTouchStart != null)
            {
                onButtonOneTouchStart.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonOneTouchStartAsObservable()
        {
            return onButtonOneTouchStart ?? (onButtonOneTouchStart = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onButtonOneTouchStart != null)
            {
                onButtonOneTouchStart.OnCompleted();
            }
        }
    }
}