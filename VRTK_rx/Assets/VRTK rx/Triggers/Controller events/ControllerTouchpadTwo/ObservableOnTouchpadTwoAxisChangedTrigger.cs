using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnTouchpadTwoAxisChangedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTouchpadTwoAxisChanged;

        public void OnTouchpadTwoAxisChanged(object sender, ControllerInteractionEventArgs e)
        {
            if (onTouchpadTwoAxisChanged != null)
            {
                onTouchpadTwoAxisChanged.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoAxisChangedAsObservable()
        {
            return onTouchpadTwoAxisChanged ?? (onTouchpadTwoAxisChanged = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onTouchpadTwoAxisChanged != null)
            {
                onTouchpadTwoAxisChanged.OnCompleted();
            }
        }
    }
}