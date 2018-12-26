using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnGripClickedTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onGripClicked;

        public void OnGripClicked(object sender, ControllerInteractionEventArgs e) {
            if (onGripClicked != null) {
                onGripClicked.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnGripClickedAsObservable() {
            return onGripClicked ?? (onGripClicked = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onGripClicked != null) {
                ob.GripClicked -= OnGripClicked;
                onGripClicked.OnCompleted();
            }
        }
    }
}