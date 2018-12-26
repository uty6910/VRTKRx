using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnButtonOneReleasedTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onButtonOneReleased;

        public void OnButtonOneReleased(object sender, ControllerInteractionEventArgs e) {
            if (onButtonOneReleased != null) {
                onButtonOneReleased.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonOneReleasedAsObservable() {
            return onButtonOneReleased ?? (onButtonOneReleased = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onButtonOneReleased != null) {
                ob.ButtonOneReleased -= OnButtonOneReleased;
                onButtonOneReleased.OnCompleted();
            }
        }
    }
}