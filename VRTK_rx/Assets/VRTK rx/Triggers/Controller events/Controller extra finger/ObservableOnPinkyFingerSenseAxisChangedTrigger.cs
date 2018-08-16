using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnPinkyFingerSenseAxisChangedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onPinkyFingerSenseAxisChanged;

        public void OnPinkyFingerSenseAxisChanged(object sender, ControllerInteractionEventArgs e)
        {
            if (onPinkyFingerSenseAxisChanged != null)
            {
                onPinkyFingerSenseAxisChanged.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnPinkyFingerSenseAxisChangedAsObservable()
        {
            return onPinkyFingerSenseAxisChanged ?? (onPinkyFingerSenseAxisChanged = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onPinkyFingerSenseAxisChanged != null)
            {
                onPinkyFingerSenseAxisChanged.OnCompleted();
            }
        }
    }
}