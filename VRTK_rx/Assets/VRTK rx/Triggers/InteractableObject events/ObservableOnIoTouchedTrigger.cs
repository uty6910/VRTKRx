using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers
{
    [DisallowMultipleComponent]
    public class ObservableOnIoTouchedTrigger : ObservableTriggerBase
    {
        private Subject<Tuple<object, InteractableObjectEventArgs>> onIoTouched;

        public void OnIoTouched(object sender, InteractableObjectEventArgs e)
        {
            if (onIoTouched != null)
            {
                onIoTouched.OnNext(new Tuple<object, InteractableObjectEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, InteractableObjectEventArgs>> OnIoTouchedAsObservable()
        {
            return onIoTouched ?? (onIoTouched = new Subject<Tuple<object, InteractableObjectEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (onIoTouched != null)
            {
                onIoTouched.OnCompleted();
            }
        }
    }
}