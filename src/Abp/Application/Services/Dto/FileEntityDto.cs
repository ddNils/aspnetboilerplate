using System;

namespace Abp.Application.Services.Dto
{
    /// <summary>
    /// a shortcut to <see cref="FileEntityDtoOfTPrimaryKey{TPrimaryKey}"/> for most used primary key type (<see cref="int"/>).
    /// </summary>
    [Serializable]
    public class FileEntityDto: FileEntityDtoOfTPrimaryKey<int>
    {
    }
    
}
