using Arch.Core.Utils;

namespace Arch.Core.Extensions.Dangerous;

/// <summary>
///     The <see cref="DangerousArchetypeExtensions"/> class
///     contains several <see cref="Archetype"/> related extension methods which give acess to underlaying data structures that should only be modified when you exactly know what you are doing.
/// </summary>
public static class DangerousArchetypeExtensions
{

    /// <summary>
    ///     Creates a new <see cref="Archetype"/> and returns it. 
    /// </summary>
    /// <param name="archetype">The <see cref="Archetype"/>.</param>
    /// <param name="types">The <see cref="ComponentType"/>s.</param>
    /// <returns></returns>
    public static Archetype CreateArchetype(this Archetype archetype, ComponentType[] types)
    {
        return new Archetype(types);
    }

    /// <summary>
    ///     Sets the <see cref="Archetype.Size"/>.
    /// </summary>
    /// <param name="archetype">The <see cref="Archetype"/>.</param>
    /// <param name="size">The size.</param>
    public static void SetSize(this Archetype archetype, int size)
    {
        archetype.Size = size;
    }

    /// <summary>
    ///     Sets the <see cref="Archetype.Chunks"/> and its capacity. 
    /// </summary>
    /// <param name="archetype">The <see cref="Archetype"/> instance.</param>
    /// <param name="chunks">The list of <see cref="Chunk"/>s.</param>
    public static void SetChunks(this Archetype archetype, List<Chunk> chunks)
    {
        archetype.Chunks = chunks.ToArray();
        archetype.Capacity = chunks.Count;
    }
}
