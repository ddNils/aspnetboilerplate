using System;

namespace Abp.Application.Services.Dto
{
    /// <summary>
    /// saves files in database
    /// </summary>
    /// <typeparam name="TPrimaryKey"></typeparam>
    [Serializable]
    public class FileEntityDtoOfTPrimaryKey<TPrimaryKey>: IEntityDto<TPrimaryKey>
    {
        /// <summary>
        /// Id of the entity.
        /// </summary>
        public TPrimaryKey Id { get; set; }
        /// <summary>
        /// This holds the bytearray contents of the file
        /// </summary>
        public Byte[] FileContent { get; set; }
        /// <summary>
        /// holds the size of the file in bytes
        /// </summary>
        public int FileSize { get; set; }
        /// <summary>
        /// holds the filename (without extension) 
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// holds the extension or filetype
        /// </summary>
        public string FileExtension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        protected FileEntityDtoOfTPrimaryKey()
        {
            if (this.FileContent != null)
            {
                this.FileSize = FileContent.Length;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        protected FileEntityDtoOfTPrimaryKey(TPrimaryKey id)
        {
            this.Id = id;
            if (this.FileContent != null)
            {
                this.FileSize = FileContent.Length;
            }
        }
    }
}
