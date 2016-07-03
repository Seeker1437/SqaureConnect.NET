using Newtonsoft.Json;
using SquareConnect.Util;
using SquareConnect.V1.Enums;

namespace SquareConnect.V1.Types
{
    /// <summary>
    /// Represents a cell of a <see cref="Page"/>.
    /// </summary>
    public class PageCell
    {
        /// <summary>
        /// The unique identifier of the page the cell is included on.
        /// </summary>
        [JsonProperty("page_cell")]
        public string PageId;

        /// <summary>
        /// The row of the cell. Always an integer between 0 and 4, inclusive.
        /// </summary>
        [JsonProperty("row")]
        public int Row;

        /// <summary>
        /// The column of the cell. Always an integer between 0 and 4, inclusive.
        /// </summary>
        [JsonProperty("colomn")]
        public int Colomn;

        [JsonProperty("object_type")]
        internal string _objectType;

        /// <summary>
        /// The type of entity represented in the cell (<see cref="Enums.PageCellType.Item"/>, <see cref="Enums.PageCellType.Discount"/>, <see cref="Enums.PageCellType.Category"/>, or <see cref="Enums.PageCellType.Placeholder"/>).
        /// </summary>
        public PageCellType ObjectType => ObjectHelper.GetEnumFromDescription<PageCellType>(_objectType);

        /// <summary>
        /// The unique identifier of the entity represented in the cell. Not present for cells with an <see cref="ObjectType"/> of <see cref="Discount"/>
        /// </summary>
        [JsonProperty("object_id")]
        public string ObjectId;

        [JsonProperty("placeholder_type")]
        internal string _placeholderType;

        /// <summary>
        /// For a cell with an <see cref="ObjectType"/> of <see cref="Discount"/>, this value indicates the cell's special behavior.
        /// </summary>
        public PageCellPlaceholderType PlaceholderType
            => ObjectHelper.GetEnumFromDescription<PageCellPlaceholderType>(_placeholderType);
    }
}
