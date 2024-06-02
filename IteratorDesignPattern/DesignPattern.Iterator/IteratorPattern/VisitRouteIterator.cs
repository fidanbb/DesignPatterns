namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteIterator : IIterator<VisitRoute>
    {
        private readonly VisitRouteMover _visitRouteMover;

        public VisitRouteIterator(VisitRouteMover visitRouteMover)
        {
            _visitRouteMover = visitRouteMover;
        }

        private int CurrentIndex = 0;

        public VisitRoute CurrentItem { get; set; }

        public bool NextLocation()
        {
            if (CurrentIndex < _visitRouteMover.VisitRouteCount)
            {
                CurrentItem = _visitRouteMover.visitRoutes[CurrentIndex++];

                return true;
            }

            return false;
        }
    }
}
