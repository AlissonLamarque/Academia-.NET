namespace PadroesDeProjeto.PPMediator
{
    public abstract class Colega
    {
        protected Mediator _mediator;

        public Colega(Mediator mediator)
        {
            this._mediator = mediator;
        }
    }
}