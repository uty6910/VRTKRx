using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnIoUnusedTrigger : ObservableTriggerBase {
        public VRTK_InteractableObject ob;

        private Subject<Tuple<object, InteractableObjectEventArgs>> onIoUnused;

        public void OnIoUnused(object sender, InteractableObjectEventArgs e) {
            if (onIoUnused != null) {
                onIoUnused.OnNext(new Tuple<object, InteractableObjectEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoUnusedAsObservable() {
            return onIoUnused ?? (onIoUnused = new Subject<Tuple<object, InteractableObjectEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onIoUnused != null) {
                ob.InteractableObjectUnused -= OnIoUnused;
                onIoUnused.OnCompleted();
            }
        }
    }
}