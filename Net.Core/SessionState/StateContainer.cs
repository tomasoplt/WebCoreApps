using System;

namespace Net.Core.SessionState
{
    public class StateContainer
    {
        public string UserName { get; private set; } = "";

        public event Action OnChange;

        public void SetName(string value)
        {
            UserName = value;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}
