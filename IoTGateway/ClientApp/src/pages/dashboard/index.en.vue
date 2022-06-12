<template>
    <div class="dashboard-container">
        <el-row :gutter="12">
            <el-col :span="8" :xs="24">
                <chart-card :chart-data="dailySalesChart.data" :chart-options="dailySalesChart.options" :chart-type="dailySalesChart.type" backgroundColor="blue">
                    <template slot="content">
                        <h4 class="title">Daily Sales------</h4>
                        <p class="category">
                            <span class="text-success"><i class="el-icon-top"></i> 55% </span>
                            increase in today sales.
                        </p>
                    </template>
                    <template slot="footer">
                        <div class="stats">
                            <i class="el-icon-time"></i>
                            updated 4 minutes ago
                        </div>
                    </template>
                </chart-card>
            </el-col>
            <el-col :span="8" :xs="24">
                <chart-card :chart-data="dataCompletedTasksChart.data" :chart-options="dataCompletedTasksChart.options" :chart-type="dataCompletedTasksChart.type" backgroundColor="red">
                    <template slot="content">
                        <h4 class="title">Email Subscription</h4>
                        <p class="category">
                            Last Campaign Performance.
                        </p>
                    </template>
                    <template slot="footer">
                        <div class="stats">
                            <i class="el-icon-time"></i>
                            updated 10 days ago
                        </div>
                    </template>
                </chart-card>
            </el-col>
            <el-col :span="8" :xs="24">
                <chart-card :chart-data="emailsSubscriptionChart.data" :chart-options="emailsSubscriptionChart.options" backgroundColor="green">
                    <template slot="content">
                        <h4 class="title">Completed Tasks</h4>
                        <p class="category">
                            Last Campaign Performance.
                        </p>
                    </template>
                    <template slot="footer">
                        <div class="stats">
                            <i class="el-icon-time"></i>
                            campaign sent 26 minutes ago
                        </div>
                    </template>
                </chart-card>
            </el-col>
        </el-row>
        <el-row :gutter="12">
            <el-col :span="6" :xs="24">
                <stats-card backgroundColor="purple" elIcon="el-icon-star-on">
                    <template slot="content">
                        <p class="category">Star</p>
                        <h3 class="title">
                            {{ getGithubInfoData.stargazers_count || "-" }}
                        </h3>
                    </template>
                    <template slot="footer">
                        <div class="stats">
                            <i class="el-icon-time"></i>
                            Last 24 Hours
                        </div>
                    </template>
                </stats-card>
            </el-col>
            <el-col :span="6" :xs="24">
                <stats-card backgroundColor="green" elIcon="el-icon-mobile">
                    <template slot="content">
                        <p class="category">Fork</p>
                        <h3 class="title">{{ getGithubInfoData.forks_count || "-" }}</h3>
                    </template>
                    <template slot="footer">
                        <div class="stats">
                            <i class="el-icon-time"></i>
                            Last 24 Hours
                        </div>
                    </template>
                </stats-card>
            </el-col>
            <el-col :span="6" :xs="24">
                <stats-card backgroundColor="orange" elIcon="el-icon-stopwatch">
                    <template slot="content">
                        <p class="category">Watch</p>
                        <h3 class="title">
                            {{ getGithubInfoData.subscribers_count || "-" }}
                        </h3>
                    </template>
                    <template slot="footer">
                        <div class="stats">
                            <i class="el-icon-time"></i>
                            Last 24 Hours
                        </div>
                    </template>
                </stats-card>
            </el-col>
            <el-col :span="6" :xs="24">
                <stats-card backgroundColor="red" elIcon="el-icon-info">
                    <template slot="content">
                        <p class="category">Issue</p>
                        <h3 class="title">
                            {{ getGithubInfoData.open_issues_count || "-" }}
                        </h3>
                    </template>
                    <template slot="footer">
                        <div class="stats">
                            <i class="el-icon-time"></i>
                            Last 24 Hours
                        </div>
                    </template>
                </stats-card>
            </el-col>
        </el-row>
        <el-row :gutter="20">
            <el-col :span="24">
                <el-calendar v-model="value" />
            </el-col>
        </el-row>
    </div>
</template>

<script lang="ts">
import indexMixin from "./index-mixin";
export default indexMixin;
</script>
<style lang="less">
.lump-wrap {
    .el-link.el-link--default {
        width: 100%;
        .el-link--inner {
            width: 100%;
        }
    }
}
</style>
<style lang="less" rel="stylesheet/less" scoped>
@import "~@/assets/css/mixin.less";
.dashboard-container {
    padding: 10px;
    p {
        text-indent: 2em;
    }
    .title {
        margin-bottom: 5px;
        font-weight: 300;
        font-size: 16px;
    }
    .category {
        text-indent: 0;
        color: #999999;
        .text-success {
            color: red;
        }
    }
    .stats {
        color: #999999;
    }

    .el-row {
        margin-bottom: 20px;
    }
    .el-card__header {
        color: #333;
        font-size: 14px;
    }
    .el-card {
        font-size: 14px;
        color: #666;
    }
    .lump-wrap {
        margin-bottom: 0;
        min-height: 160px;
        text-align: center;
        &.cxt-left {
            .el-col {
                .flexalign(flex-start);
                box-sizing: border-box;
                padding-bottom: 10px;
                div {
                    background-color: #f8f8f8;
                    width: 100%;
                    box-sizing: border-box;
                    padding: 0 10px;
                }
            }
        }
        .el-col {
            .center(column);
            i {
                width: 100%;
                height: 60px;
                line-height: 60px;
                text-align: center;
                border-radius: 2px;
                font-size: 30px;
                background-color: #f8f8f8;
            }
            h3 {
                padding: 5px 0;
                font-size: 12px;
            }
            p {
                font-style: normal;
                font-size: 30px;
                font-weight: 300;
                color: #009688;
                text-indent: 0;
            }
            .link-a {
                color: #666;
                font-size: 14px;
                text-align: center;
            }
        }
        .link-ctx {
            min-width: 80px;
        }
    }
}
</style>
