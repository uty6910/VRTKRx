using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnTriggerTouchEndTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTriggerTouchEnd;

        public void OnTriggerTouchEnd(object sender, ControllerInteractionEventArgs e) {
            if (onTriggerTouchEnd != null) {
                onTriggerTouchEnd.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerTouchEndAsObservable() {
            return onTriggerTouchEnd ?? (onTriggerTouchEnd = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onTriggerTouchEnd != null) {
                ob.TriggerTouchEnd -= OnTriggerTouchEnd;
                onTriggerTouchEnd.OnCompleted();
            }
        }
    }
}