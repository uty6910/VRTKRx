using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnButtonTwoReleasedTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onButtonTwoReleased;

        public void OnButtonTwoReleased(object sender, ControllerInteractionEventArgs e) {
            if (onButtonTwoReleased != null) {
                onButtonTwoReleased.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonTwoReleasedAsObservable() {
            return onButtonTwoReleased ?? (onButtonTwoReleased = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onButtonTwoReleased != null) {
                ob.ButtonTwoReleased -= OnButtonTwoReleased;
                onButtonTwoReleased.OnCompleted();
            }
        }
    }
}