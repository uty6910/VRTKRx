using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnTouchpadTouchStartTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTouchpadTouchStart;

        public void OnTouchpadTouchStart(object sender, ControllerInteractionEventArgs e) {
            if (onTouchpadTouchStart != null) {
                onTouchpadTouchStart.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTouchStartAsObservable() {
            return onTouchpadTouchStart ?? (onTouchpadTouchStart = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onTouchpadTouchStart != null) {
                ob.TouchpadTouchStart -= OnTouchpadTouchStart;
                onTouchpadTouchStart.OnCompleted();
            }
        }
    }
}