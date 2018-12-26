using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnTouchpadAxisChangedTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTouchpadAxisChanged;

        public void OnTouchpadAxisChanged(object sender, ControllerInteractionEventArgs e) {
            if (onTouchpadAxisChanged != null) {
                onTouchpadAxisChanged.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadAxisChangedAsObservable() {
            return onTouchpadAxisChanged ?? (onTouchpadAxisChanged = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onTouchpadAxisChanged != null) {
                ob.TouchpadAxisChanged -= OnTouchpadAxisChanged;
                onTouchpadAxisChanged.OnCompleted();
            }
        }
    }
}