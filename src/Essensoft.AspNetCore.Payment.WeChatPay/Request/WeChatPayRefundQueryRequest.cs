using Essensoft.AspNetCore.Payment.WeChatPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    public class WeChatPayRefundQueryRequest : IWeChatPayRequest<WeChatPayRefundQueryResponse>
    {
        /// <summary>
        /// 子商户公众账号ID
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 微信订单号
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户退款单号
        /// </summary>
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 微信退款单号
        /// </summary>
        public string RefundId { get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        public string Offset { get; set; }

        #region IWeChatPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/pay/refundquery";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary()
            {
                { "sub_appid", SubAppId },
                { "sub_mch_id", SubMchId },
                { "transaction_id", TransactionId },
                { "out_trade_no", OutTradeNo },
                { "out_refund_no", OutRefundNo },
                { "refund_id", RefundId },
                { "offset", Offset },
            };
            return parameters;
        }

        #endregion
    }
}
