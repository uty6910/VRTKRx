using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnTouchpadTouchEndTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTouchpadTouchEnd;

        public void OnTouchpadTouchEnd(object sender, ControllerInteractionEventArgs e)
        {
            if (onTouchpadTouchEnd != null)
            {
                onTouchpadTouchEnd.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTouchEndAsObservable()
        {
            return onTouchpadTouchEnd ?? (onTouchpadTouchEnd = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onTouchpadTouchEnd != null)
            {
                onTouchpadTouchEnd.OnCompleted();
            }
        }
    }
}