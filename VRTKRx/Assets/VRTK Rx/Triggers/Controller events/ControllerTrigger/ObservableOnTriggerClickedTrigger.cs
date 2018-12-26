using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnTriggerClickedTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTriggerClicked;

        public void OnTriggerClicked(object sender, ControllerInteractionEventArgs e) {
            if (onTriggerClicked != null) {
                onTriggerClicked.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTriggerClickedAsObservable() {
            return onTriggerClicked ?? (onTriggerClicked = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onTriggerClicked != null) {
                ob.TriggerClicked -= OnTriggerClicked;
                onTriggerClicked.OnCompleted();
            }
        }
    }
}