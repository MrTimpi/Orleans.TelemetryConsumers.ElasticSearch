using System;

namespace Orleans.TelemetryConsumers.ElasticSearch
{
    public class ElasticsearchTelemetryConsumerOptions
    {
        public Uri ElasticSearchUri;
        public string IndexPrefix;
        public string DateFormatter;
        public int BufferWaitSeconds;
        public int BufferSize;
    }
}
