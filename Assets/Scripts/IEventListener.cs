namespace Assets.Scripts
{
    public interface IEventListener<Enum>
    {
        void Notify(Enum e);
    }
}
