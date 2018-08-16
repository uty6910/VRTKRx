using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnTriggerSenseAxisChangedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTriggerSenseAxisChanged;

        public void OnTriggerSenseAxisChanged(object sender, ControllerInteractionEventArgs e)
        {
            if (onTriggerSenseAxisChanged != null)
            {
                onTriggerSenseAxisChanged.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerSenseAxisChangedAsObservable()
        {
            return onTriggerSenseAxisChanged ?? (onTriggerSenseAxisChanged = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onTriggerSenseAxisChanged != null)
            {
                onTriggerSenseAxisChanged.OnCompleted();
            }
        }
    }
}