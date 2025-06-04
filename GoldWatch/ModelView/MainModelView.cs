using GoldWatch.Core;


namespace GoldWatch.ModelView
{
    public class MainModelView : ReactiveObject
    {
        private string _currentPrice;
        /// <summary>
        /// 当前的价格
        /// </summary>
        public string CurrentPrice
        {
            get => _currentPrice;
            set
            {
                this.RaiseAndSetIfChanged(ref _currentPrice, value);
            }
        }

        private bool _rise;

        /// <summary>
        /// 是否涨价
        /// </summary>
        public bool Rise
        {
            get => _rise;
            set
            {
                this.RaiseAndSetIfChanged(ref _rise, value);
            }
        }

        private string _priceRangePercentage;
        /// <summary>
        /// 当前的价格百分比
        /// </summary>
        public string PriceRangePercentage
        {
            get => _priceRangePercentage;
            set
            {
                this.RaiseAndSetIfChanged(ref _priceRangePercentage, value);
            }
        }

        private string _color;
        /// <summary>
        /// 颜色
        /// </summary>
        public string Color
        {
            get => _color;
            set
            {
                this.RaiseAndSetIfChanged(ref _color, value);
            }
        }
        /// <summary>
        /// 初始化
        /// </summary>
        public MainModelView()
        {
            this.WhenAnyValue(x => x._rise)
                .Subscribe(next =>
                {
                    if (next)
                    {
                        this.Color = "#4CAF50";
                    }
                    else
                    {
                        this.Color = "#F44336";
                    }
                });
            _ = Task.Run(async () =>
            {
                var result = await RequestCloud.GetGoldPrice();
                this.CurrentPrice = $"￥{result.CurrentPrice}";
                Rise = result.CalculatePriceRangePercentage() > 0 ;
                PriceRangePercentage = $"{result.CalculatePriceRangePercentage()}%";
            });
        }
    }
}