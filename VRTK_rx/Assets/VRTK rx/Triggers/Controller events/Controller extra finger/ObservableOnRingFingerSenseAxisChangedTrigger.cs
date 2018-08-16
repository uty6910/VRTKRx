using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnRingFingerSenseAxisChangedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onRingFingerSenseAxisChanged;

        public void OnRingFingerSenseAxisChanged(object sender, ControllerInteractionEventArgs e)
        {
            if (onRingFingerSenseAxisChanged != null)
            {
                onRingFingerSenseAxisChanged.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnRingFingerSenseAxisChangedAsObservable()
        {
            return onRingFingerSenseAxisChanged ?? (onRingFingerSenseAxisChanged = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onRingFingerSenseAxisChanged != null)
            {
                onRingFingerSenseAxisChanged.OnCompleted();
            }
        }
    }
}