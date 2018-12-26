using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnIoUngrabbedTrigger : ObservableTriggerBase {
        public VRTK_InteractableObject ob;

        private Subject<Tuple<object, InteractableObjectEventArgs>> onIoUngrabbed;

        public void OnIoUngrabbed(object sender, InteractableObjectEventArgs e) {
            if (onIoUngrabbed != null) {
                onIoUngrabbed.OnNext(new Tuple<object, InteractableObjectEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoUngrabbedAsObservable() {
            return onIoUngrabbed ?? (onIoUngrabbed = new Subject<Tuple<object, InteractableObjectEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onIoUngrabbed != null) {
                ob.InteractableObjectUngrabbed -= OnIoUngrabbed;
                onIoUngrabbed.OnCompleted();
            }
        }
    }
}