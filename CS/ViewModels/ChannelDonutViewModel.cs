using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCard.ViewModels {
    public class ChannelDonutViewModel {
        public ObservableCollection<TrafficChannel> TrafficChannelsData {
            get;
            set;
        }
        public Color[] TrafficColors {
            get;
            set;
        }
        public ChannelDonutViewModel() {
            TrafficChannelsData = new ObservableCollection<TrafficChannel>() {
                new TrafficChannel("Organic", 17000),
                new TrafficChannel("Direct", 6000),
                new TrafficChannel("Referral", 2000),
                new TrafficChannel("Social", 900)
            };
            TrafficColors = new Color[] { 
                Color.FromArgb("#80cbc4"),
                Color.FromArgb("#bcaaa4"),
                Color.FromArgb("#ffab91"),
                Color.FromArgb("#9fa8da"),
            };
        }

    }
    public class TrafficChannel {
        public string ChannelName { get; }
        public double Value { get; }

        public TrafficChannel(string channelName, double value) {
            ChannelName = channelName;
            Value = value;
        }
    }
}
