using UnityEngine;
using UniRx;
using UniRx.Triggers;
using VRTK;

namespace VrtkRx.Triggers {

    [DisallowMultipleComponent]
    public class ObservableOnHighlighterTrigger : ObservableTriggerBase {
        public VRTK_InteractObjectHighlighter ob;

        private Subject<Tuple<object, InteractObjectHighlighterEventArgs>> onIoHighlight;

        public void OnHighligted(object sender, InteractObjectHighlighterEventArgs e) {
            if (onIoHighlight != null) {
                onIoHighlight.OnNext(new Tuple<object, InteractObjectHighlighterEventArgs>(sender, e));
            }
        }

        public IObservable<Tuple<object, InteractObjectHighlighterEventArgs>> OnHighlighterAsObservable() {
            return onIoHighlight ?? (onIoHighlight = new Subject<Tuple<object, InteractObjectHighlighterEventArgs>>());
        }

        protected override void RaiseOnCompletedOnDestroy() {
            if (onIoHighlight != null) {
                ob.InteractObjectHighlighterHighlighted -= OnHighligted;
                onIoHighlight.OnCompleted();
            }
        }
    }
}