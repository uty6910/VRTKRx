using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnIoGrabbedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, InteractableObjectEventArgs>> onIoGrabbed;

        public void OnIoGrabbed(object sender, InteractableObjectEventArgs e)
        {
            if (onIoGrabbed != null)
            {
                onIoGrabbed.OnNext(new Tuple<object, InteractableObjectEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoGrabbedAsObservable()
        {
            return onIoGrabbed ?? (onIoGrabbed = new Subject<Tuple<object, InteractableObjectEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onIoGrabbed != null)
            {
                onIoGrabbed.OnCompleted();
            }
        }
    }
}