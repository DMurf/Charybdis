namespace Charybdis.Core.Entities
{
    public class VisualMeasure
    {
        public bool ShowROT { get; set; } = false;
        public bool ShowChart { get; set; } = false;

        public string TableId { get; set; } = default!;

        public string ChartId { get; set; } = default!;
        public string[] ChartTableLabels { get; set; } = default!;
        public string ChartTableLabelString => $"[\"{string.Join("\",\"", ChartTableLabels)}\"]";
        public string[] ChartDataValues { get; set; } = default!;
        public string ChartDataValuesString => $"[\"{string.Join("\",\"", ChartDataValues)}\"]";

        public string ROTId { get; set; } = default!;

        public string[] ROTDataScaleLabels { get; set; } = new[] { "2024 to 2025", "2023 to 2024", "2022 to 2023" };
        public string ROTDataScaleLabelsString => $"[\"{string.Join("\",\"", ROTDataScaleLabels)}\"]";

        public string[] ROTDataTableLabels { get; set; } = default!;
        public string ROTDataTableLabelsString => $"[\"{string.Join("\",\"", ROTDataTableLabels)}\"]";
        public string[] ROTDataValuesY1 { get; set; } = default!;
        public string ROTDataValuesY1String => $"[\"{string.Join("\",\"", ROTDataValuesY1)}\"]";
        public string[] ROTDataValuesY2 { get; set; } = default!;
        public string ROTDataValuesY2String => $"[\"{string.Join("\",\"", ROTDataValuesY2)}\"]";
        public string[] ROTDataValuesY3 { get; set; } = default!;
        public string ROTDataValuesY3String => $"[\"{string.Join("\",\"", ROTDataValuesY3)}\"]";


    }
}
