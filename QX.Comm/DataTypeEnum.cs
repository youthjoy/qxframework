using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QX.Comm
{
    public enum AllotType
    {
        Distribution,
        CC
    }
    public enum BanlanceStatusTypeEnum
    {
        /// <summary>
        /// 财务确认结算单
        /// </summary>
        NT,
        /// <summary>
        /// 系统静态结算单
        /// </summary>
        ST,
    }

    public enum RefMonyOpTypeEnum
    {
        /// <summary>
        /// 发票
        /// </summary>
        INVOICE,
        /// <summary>
        /// 结算单
        /// </summary>
        BANLANCE,
        /// <summary>
        /// 付款
        /// </summary>
        PAY

    }

    public enum RefMoneyOpEnum {
        Add,
        Del,
    }

    public enum MapModuleEnum
    { 
        PUModule,
        WH_IOMainModule
    }

    public enum DataTypeEnum
    {
        //教育经历
        Education,
        //个人
        PersonEx
    }

    public enum DataITypeEnum
    { 
        Cust,
        PreCust,
        Sup
    }

    /// <summary>
    /// 合同状态
    /// </summary>
    public enum ContractTypeEnum
    {
        /// <summary>
        /// 有效
        /// </summary>
        Valid,
        /// <summary>
        /// 无效
        /// </summary>
        InValid,
        /// <summary>
        /// 草稿
        /// </summary>
        Draft
    }


    /// <summary>
    /// 库存移动类型
    /// </summary>
    public enum MovementTypeEnum
    {
        /// <summary>
        /// 请购单
        /// </summary>
        Apply,
        /// <summary>
        /// 采购单
        /// </summary>
        Stock,
        /// <summary>
        /// 入库单
        /// </summary>
        StockIn,
        /// <summary>
        /// 出库单
        /// </summary>
        StockOut,
        /// <summary>
        /// 一般入库
        /// </summary>
        GStockIn,
        /// <summary>
        /// 一般出库
        /// </summary>
        GStonOut
    }

    /// <summary>
    /// 收货状态
    /// </summary>
    public enum GoodsReciveTypeEnum
    {
        /// <summary>
        /// 待收货订单：审核完成后自动变成待收货
        /// </summary>
        WaitRecive,
        /// <summary>
        /// 已收货订单
        /// </summary>
        Recived
    }

    /// <summary>
    /// 审核状态
    /// </summary>
    public enum AudtiOperaTypeEnum
    {
        /// <summary>
        /// 待审状态
        /// </summary>
        Auditing,
        /// <summary>
        /// 终审
        /// </summary>
        LastAudit,
        /// <summary>
        /// 审核进行中
        /// </summary>
        OnAudit,
        /// <summary>
        /// 废单
        /// </summary>
        Litter
    }
    /// <summary>
    /// 审核记录类型
    /// </summary>
    public enum AudtiRecordsDataTypeEnum
    {
        /// <summary>
        /// 已审通过
        /// </summary>
        Audited,
        /// <summary>
        /// 驳回
        /// </summary>
        Reject
    }


    public enum DictKeyEnum
    {
        /// <summary>
        /// 性别
        /// </summary>
        GENDER,
        /// <summary>
        /// 库存移动类型
        /// </summary>
        MVITYPE,
        /// <summary>
        /// 员工状态（在职、离职。。。）
        /// </summary>
        STUFFSTAT,
        /// <summary>
        /// 员工职称
        /// </summary>
        STUFFTITLE,
        /// <summary>
        /// 考勤类型
        /// </summary>
        TSTYPE

    }

    public enum AuditModuleEnum
    {
        /// <summary>
        /// 供应商审核模块
        /// </summary>
        AuditVender,
        /// <summary>
        /// 请购单审核模块
        /// </summary>
        AuditApplyBuy,
        /// <summary>
        /// PU单据审核
        /// </summary>
        AuditStock,
        /// <summary>
        /// 出库单模块
        /// </summary>
        IOMainAudit,
        /// <summary>
        /// 销售合同审核模块
        /// </summary>
        ContractAudit,
        /// <summary>
        /// 设备维修计划
        /// </summary>
        AssetMPlanAudit,
        /// <summary>
        /// 设备报修单
        /// </summary>
        AssetMApplyAudit,
        /// <summary>
        /// 设备报废单
        /// </summary>
        AssetProcessAudit,
        /// <summary>
        /// 公文审核流程
        /// </summary>
        DocumentAudit,
        /// <summary>
        /// 零件图纸审核
        /// </summary>
        CompAudit,
        /// <summary>
        /// 共享文档审核
        /// </summary>
        ComFileAudit
        
    }

    public enum JqGridEnum
    {
        add,
        edit,
        del,
        view
    }


    public enum PUStatEnum
    {
        /// <summary>
        /// 未收货
        /// </summary>
        NoReceive,
        /// <summary>
        ///已收，但未收完
        /// </summary>
        Receive,
        /// <summary>
        /// 已收完
        /// </summary>
        Finish
    }

    public enum PUTypeEnum
    {
        /// <summary>
        /// 采购订单
        /// </summary>
        PO,
        /// <summary>
        /// 采购收货
        /// </summary>
        PRR,
        /// <summary>
        /// 采购退货
        /// </summary>
        PR,
        /// <summary>
        /// 采购换货入库 
        /// </summary>
        PRI,
        /// <summary>
        /// 采购换货出库
        /// </summary>
        PRO,
        /// <summary>
        /// 甲供收货：
        /// </summary>
        JRI,
        /// <summary>
        /// 甲供出库:
        /// </summary>
        JO,
        /// <summary>
        /// 柴油入库
        /// </summary>
        DRI,
        /// <summary>
        /// 外修
        /// </summary>
        RO,
        /// <summary>
        /// 外加工
        /// </summary>
        WO,
        /// <summary>
        /// 行政物资采购
        /// </summary>
        APO,
        /// <summary>
        /// 行政物资收货
        /// </summary>
        API,
        /// <summary>
        /// 行政物资退货
        /// </summary>
        APR,
        /// <summary>
        /// 设备采购
        /// </summary>
        EPO,
        /// <summary>
        /// 设备入库
        /// </summary>
        EPI,
        /// <summary>
        /// 设备换货入库
        /// </summary>
        EPRI,
       /// <summary>
        /// 设备换货出库
       /// </summary>
        EPRO,
        /// <summary>
        /// 设备退货
        /// </summary>
        EPR,
        /// <summary>
        /// 行政固定资产采购
        /// </summary>
        ASPO,
        /// <summary>
        /// 固定资产入库
        /// </summary>
        ASPI,
        /// <summary>
        /// 固定资产换货出库
        /// </summary>
        ASPRO,
        /// <summary>
        /// 固定资产换货入库
        /// </summary>
        ASPRI,
        /// <summary>
        /// 固定资产退货
        /// </summary>
        ASPR,
        /// <summary>
        /// 工作服入库
        /// </summary>
        CPI

    }

    /// <summary>
    /// 结算状态
    /// </summary>
    public enum BanlanceTypeEnum
    {
        /// <summary>
        /// 未结算
        /// </summary>
        UnSettle,
        /// <summary>
        /// 已结算
        /// </summary>
        Settled,
    }

    /// <summary>
    /// 付款状态
    /// </summary>
    public enum PayMoenyEnum
    {
        /// <summary>
        /// 未付款
        /// </summary>
        UnPay=0,
        /// <summary>
        /// 已付款
        /// </summary>
        Payed=1
    }

    
    /// <summary>
    /// 支付状态
    /// </summary>
    public enum PayStatEnum
    {
        /// <summary>
        /// 未支付
        /// </summary>
        UNPAY,
        /// <summary>
        /// 已支付
        /// </summary>
        PAYED
    }

    public enum CarStatEnum
    {
        /// <summary>
        /// 行驶中
        /// </summary>
        Running,
        /// <summary>
        /// 停止
        /// </summary>
        Stopped
    }
    /// <summary>
    /// 设备状态
    /// </summary>
    public enum EquEnum
    {
        /// <summary>
        /// 未注明
        /// </summary>
        wzm,
        /// <summary>
        /// 已领用
        /// </summary>
        ly,
        /// <summary>
        /// 未领用
        /// </summary>
        wly,
        /// <summary>
        /// 报废
        /// </summary>
        bf,
        /// <summary>
        /// 维修
        /// </summary>
        wx,
        /// <summary>
        /// 退货
        /// </summary>
        /// 
        th
    }
    public enum VehicLE:int
    {
        /// 报废
        /// </summary>
        bf=15
    }
    public enum HouseTypeEnum
    {
        /// <summary>
        /// 机零配件
        /// </summary>
        WAREMM,
        /// <summary>
        /// 行政物资
        /// </summary>
        WAREMO,
        /// <summary>
        /// 设备（技术)
        /// </summary>
        WAREMET,
        /// <summary>
        /// 设备(生产)
        /// </summary>
        WAREMEP,
        /// <summary>
        /// 设备固定资产
        /// </summary>
        WAREMA,
        /// <summary>
        /// 工作服
        /// </summary>
        WARECLO
    }

    /// <summary>
    /// 盘点计划是否生成盘点单
    /// </summary>
    public enum CREATEPLAN
    {
        /// <summary>
        /// 是
        /// </summary>
        CPTrue,
        /// <summary>
        /// 否
        /// </summary>
        CPFalse
    }

    public enum CHECKSTATUS
    {
        /// <summary>
        /// 盘点处理未完成
        /// </summary>
        False,
        /// <summary>
        /// 盘点处理完成
        /// </summary>
        True
    }

    /// <summary>
    /// 特殊字典
    /// </summary>
    public enum SPECDICT
    {
        /// <summary>
        /// 物料类别维护
        /// </summary>
        MMTYPE
    }

}
