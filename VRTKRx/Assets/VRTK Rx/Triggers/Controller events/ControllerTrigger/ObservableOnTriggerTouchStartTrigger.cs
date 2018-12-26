using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnTriggerTouchStartTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTriggerTouchStart;

        public void OnTriggerTouchStart(object sender, ControllerInteractionEventArgs e) {
            if (onTriggerTouchStart != null) {
                onTriggerTouchStart.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerTouchStartAsObservable() {
            return onTriggerTouchStart ?? (onTriggerTouchStart = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onTriggerTouchStart != null) {
                ob.TriggerTouchStart -= OnTriggerTouchStart;
                onTriggerTouchStart.OnCompleted();
            }
        }
    }
}