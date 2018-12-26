using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnTouchpadTwoTouchStartTrigger : ObservableTriggerBase {
        public VRTK_ControllerEvents ob;

        private Subject<Tuple<object, ControllerInteractionEventArgs>> onTouchpadTwoTouchStart;

        public void OnTouchpadTwoTouchStart(object sender, ControllerInteractionEventArgs e) {
            if (onTouchpadTwoTouchStart != null) {
                onTouchpadTwoTouchStart.OnNext(new Tuple<object, ControllerInteractionEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, ControllerInteractionEventArgs>> OnTouchpadTwoTouchStartAsObservable() {
            return onTouchpadTwoTouchStart ?? (onTouchpadTwoTouchStart = new Subject<Tuple<object, ControllerInteractionEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onTouchpadTwoTouchStart != null) {
                ob.TouchpadTwoTouchStart -= OnTouchpadTwoTouchStart;
                onTouchpadTwoTouchStart.OnCompleted();
            }
        }
    }
}