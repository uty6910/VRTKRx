using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnGripHairlineEndTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onGripHairlineEnd;

        public void OnGripHairlineEnd(object sender, ControllerInteractionEventArgs e) {
            if (onGripHairlineEnd != null) {
                onGripHairlineEnd.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripHairlineEndAsObservable() {
            return onGripHairlineEnd ?? (onGripHairlineEnd = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onGripHairlineEnd != null) {
                ob.GripHairlineEnd -= OnGripHairlineEnd;
                onGripHairlineEnd.OnCompleted();
            }
        }
    }
}