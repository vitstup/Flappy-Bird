public class PipesPool : MonoPool<PipesBlock>
{
	public PipesPool(PipesBlock prefab, int count, bool isAutoExpanded) : base(prefab, count, isAutoExpanded)
	{

	}
}