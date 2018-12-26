using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnGripTouchEndTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onGripTouchEnd;

        public void OnGripTouchEnd(object sender, ControllerInteractionEventArgs e) {
            if (onGripTouchEnd != null) {
                onGripTouchEnd.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripTouchEndAsObservable() {
            return onGripTouchEnd ?? (onGripTouchEnd = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onGripTouchEnd != null) {
                ob.GripTouchEnd -= OnGripTouchEnd;
                onGripTouchEnd.OnCompleted();
            }
        }
    }
}