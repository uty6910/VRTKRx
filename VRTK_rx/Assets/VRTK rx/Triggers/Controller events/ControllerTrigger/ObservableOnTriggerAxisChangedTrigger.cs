using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnTriggerAxisChangedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTriggerAxisChanged;

        public void OnTriggerAxisChanged(object sender, ControllerInteractionEventArgs e)
        {
            if (onTriggerAxisChanged != null)
            {
                onTriggerAxisChanged.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerAxisChangedAsObservable()
        {
            return onTriggerAxisChanged ?? (onTriggerAxisChanged = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onTriggerAxisChanged != null)
            {
                onTriggerAxisChanged.OnCompleted();
            }
        }
    }
}