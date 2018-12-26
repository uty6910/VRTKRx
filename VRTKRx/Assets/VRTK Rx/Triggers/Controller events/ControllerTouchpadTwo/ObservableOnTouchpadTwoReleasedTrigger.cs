using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnTouchpadTwoReleasedTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTouchpadTwoReleased;

        public void OnTouchpadTwoReleased(object sender, ControllerInteractionEventArgs e) {
            if (onTouchpadTwoReleased != null) {
                onTouchpadTwoReleased.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoReleasedAsObservable() {
            return onTouchpadTwoReleased ?? (onTouchpadTwoReleased = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onTouchpadTwoReleased != null) {
                ob.TouchpadTwoReleased -= OnTouchpadTwoReleased;
                onTouchpadTwoReleased.OnCompleted();
            }
        }
    }
}