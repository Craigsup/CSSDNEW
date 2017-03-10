namespace ModifiedTicketingSystem {
    public class Barrier {
        private bool _isOpen;

        public Barrier() {
            _isOpen = false;
        }

        public void OpenBarrier() {
            _isOpen = true;
        }

        public void CloseBarrier() {
            _isOpen = false;
        }

        public bool CheckIsOpen() {
            return _isOpen;
        }
    }
}