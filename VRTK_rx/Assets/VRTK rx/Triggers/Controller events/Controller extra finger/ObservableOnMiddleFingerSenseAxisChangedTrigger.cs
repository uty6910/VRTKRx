using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnMiddleFingerSenseAxisChangedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onMiddleFingerSenseAxisChanged;

        public void OnMiddleFingerSenseAxisChanged(object sender, ControllerInteractionEventArgs e)
        {
            if (onMiddleFingerSenseAxisChanged != null)
            {
                onMiddleFingerSenseAxisChanged.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnMiddleFingerSenseAxisChangedAsObservable()
        {
            return onMiddleFingerSenseAxisChanged ?? (onMiddleFingerSenseAxisChanged = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onMiddleFingerSenseAxisChanged != null)
            {
                onMiddleFingerSenseAxisChanged.OnCompleted();
            }
        }
    }
}