using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnGripReleasedTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onGripReleased;

        public void OnGripReleased(object sender, ControllerInteractionEventArgs e) {
            if (onGripReleased != null) {
                onGripReleased.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripReleasedAsObservable() {
            return onGripReleased ?? (onGripReleased = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onGripReleased != null) {
                ob.GripReleased -= OnGripReleased;
                onGripReleased.OnCompleted();
            }
        }
    }
}