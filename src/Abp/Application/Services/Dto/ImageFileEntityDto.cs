using System;

namespace Abp.Application.Services.Dto
{
    /// <summary>
    /// A shortcut of <see cref="ImageFileEntityDtoOfTPrimaryKey{TPrimaryKey}"/> for most used primary key type <see cref="int"/>
    /// </summary>
    public class ImageFileEntityDto: ImageFileEntityDtoOfTPrimaryKey<int>
    {
    }
}
