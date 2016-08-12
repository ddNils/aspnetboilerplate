using System;

namespace Abp.Application.Services.Dto
{
    /// <summary>
    /// for storing images in database. should hold functions to scale image through partials
    /// http://stackoverflow.com/questions/1922040/resize-an-image-c-sharp
    /// </summary>
    /// <typeparam name="TPrimaryKey"></typeparam>
    [Serializable]
    public partial class ImageFileEntityDtoOfTPrimaryKey<TPrimaryKey>: FileEntityDtoOfTPrimaryKey<TPrimaryKey>
    {
        /// <summary>
        /// width in pixels for the saved image
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// height in pixels for the saved image
        /// </summary>
        public int Height { get; set; }
    }
}
