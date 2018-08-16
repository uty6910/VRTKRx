using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnTouchpadReleasedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTouchpadReleased;

        public void OnTouchpadReleased(object sender, ControllerInteractionEventArgs e)
        {
            if (onTouchpadReleased != null)
            {
                onTouchpadReleased.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadReleasedAsObservable()
        {
            return onTouchpadReleased ?? (onTouchpadReleased = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onTouchpadReleased != null)
            {
                onTouchpadReleased.OnCompleted();
            }
        }
    }
}