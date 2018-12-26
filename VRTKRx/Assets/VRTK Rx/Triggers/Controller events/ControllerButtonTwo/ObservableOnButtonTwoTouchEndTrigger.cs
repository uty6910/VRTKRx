using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnButtonTwoTouchEndTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onButtonTwoTouchEnd;

        public void OnButtonTwoTouchEnd(object sender, ControllerInteractionEventArgs e) {
            if (onButtonTwoTouchEnd != null) {
                onButtonTwoTouchEnd.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnButtonTwoTouchEndAsObservable() {
            return onButtonTwoTouchEnd ?? (onButtonTwoTouchEnd = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onButtonTwoTouchEnd != null) {
                ob.ButtonTwoTouchEnd -= OnButtonTwoTouchEnd;
                onButtonTwoTouchEnd.OnCompleted();
            }
        }
    }
}