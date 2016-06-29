using Newtonsoft.Json;

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

        /// <summary>
        /// The type of entity represented in the cell (<see cref="Enums.PageCellType.Item"/>, <see cref="Enums.PageCellType.Discount"/>, <see cref="Enums.PageCellType.Category"/>, or <see cref="Enums.PageCellType.Placeholder"/>).
        /// </summary>
        [JsonProperty("object_type")]
        public string ObjectType;

        /// <summary>
        /// The unique identifier of the entity represented in the cell. Not present for cells with an <see cref="ObjectType"/> of <see cref="Enums.PageCellPlaceholderType.Discount"/>
        /// </summary>
        [JsonProperty("object_id")]
        public string ObjectId;

        /// <summary>
        /// For a cell with an <see cref="ObjectType"/> of <see cref="Enums.PageCellPlaceholderType.Discount"/>, this value indicates the cell's special behavior.
        /// </summary>
        [JsonProperty("placeholder_type")]
        public string PlaceholderType;
    }
}
