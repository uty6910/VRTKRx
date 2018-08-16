using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnGripAxisChangedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, ControllerInteractionEventArgs>> onGripAxisChanged;

        public void OnGripAxisChanged(object sender, ControllerInteractionEventArgs e)
        {
            if (onGripAxisChanged != null)
            {
                onGripAxisChanged.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripAxisChangedAsObservable()
        {
            return onGripAxisChanged ?? (onGripAxisChanged = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onGripAxisChanged != null)
            {
                onGripAxisChanged.OnCompleted();
            }
        }
    }
}