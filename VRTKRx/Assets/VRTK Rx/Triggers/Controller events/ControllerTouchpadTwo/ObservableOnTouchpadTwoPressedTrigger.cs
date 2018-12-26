using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnTouchpadTwoPressedTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTouchpadTwoPressed;

        public void OnTouchpadTwoPressed(object sender, ControllerInteractionEventArgs e) {
            if (onTouchpadTwoPressed != null) {
                onTouchpadTwoPressed.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoPressedAsObservable() {
            return onTouchpadTwoPressed ?? (onTouchpadTwoPressed = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onTouchpadTwoPressed != null) {
                ob.TouchpadTwoPressed -= OnTouchpadTwoPressed;
                onTouchpadTwoPressed.OnCompleted();
            }
        }
    }
}