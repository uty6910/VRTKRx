using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnGripUnclickedTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onGripUnclicked;

        public void OnGripUnclicked(object sender, ControllerInteractionEventArgs e) {
            if (onGripUnclicked != null) {
                onGripUnclicked.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripUnclickedAsObservable() {
            return onGripUnclicked ?? (onGripUnclicked = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onGripUnclicked != null) {
                ob.GripUnclicked -= OnGripUnclicked;
                onGripUnclicked.OnCompleted();
            }
        }
    }
}