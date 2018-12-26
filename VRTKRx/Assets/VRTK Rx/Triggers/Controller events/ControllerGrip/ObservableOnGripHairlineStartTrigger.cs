using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnGripHairlineStartTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onGripHairlineStart;

        public void OnGripHairlineStart(object sender, ControllerInteractionEventArgs e) {
            if (onGripHairlineStart != null) {
                onGripHairlineStart.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripHairlineStartAsObservable() {
            return onGripHairlineStart ?? (onGripHairlineStart = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onGripHairlineStart != null) {
                ob.GripHairlineStart -= OnGripHairlineStart;
                onGripHairlineStart.OnCompleted();
            }
        }
    }
}