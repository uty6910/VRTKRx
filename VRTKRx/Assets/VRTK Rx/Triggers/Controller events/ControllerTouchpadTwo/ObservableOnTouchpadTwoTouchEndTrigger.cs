using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnTouchpadTwoTouchEndTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTouchpadTwoTouchEnd;

        public void OnTouchpadTwoTouchEnd(object sender, ControllerInteractionEventArgs e) {
            if (onTouchpadTwoTouchEnd != null) {
                onTouchpadTwoTouchEnd.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoTouchEndAsObservable() {
            return onTouchpadTwoTouchEnd ?? (onTouchpadTwoTouchEnd = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onTouchpadTwoTouchEnd != null) {
                ob.TouchpadTwoTouchEnd -= OnTouchpadTwoTouchEnd;
                onTouchpadTwoTouchEnd.OnCompleted();
            }
        }
    }
}