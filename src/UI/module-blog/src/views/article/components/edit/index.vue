<template>
  <nm-form-dialog ref="form" v-bind="form" v-on="on" :visible.sync="visible_">
    <el-row>
      <el-col :span="20" :offset="1">
        <el-form-item label="标题：" prop="title">
          <el-input v-model="form.model.title" clearable/>
        </el-form-item>
        <el-form-item label="所属分类：" prop="categoryId">
          <el-input v-model="form.model.categoryId" clearable/>
        </el-form-item>
        <el-form-item label="多媒体类型：" prop="mediaType">
          <el-input v-model="form.model.mediaType" clearable/>
        </el-form-item>
        <el-form-item label="简介：" prop="summary">
          <el-input v-model="form.model.summary" clearable/>
        </el-form-item>
        <el-form-item label="内容：" prop="content">
          <el-input v-model="form.model.content" clearable/>
        </el-form-item>
        <el-form-item label="私有的：" prop="private">
          <el-input v-model="form.model.private" clearable/>
        </el-form-item>
        <el-form-item label="已发布的：" prop="published">
          <el-input v-model="form.model.published" clearable/>
        </el-form-item>
        <el-form-item label="发布日期：" prop="publishedTime">
          <el-input v-model="form.model.publishedTime" clearable/>
        </el-form-item>
        <el-form-item label="阅读数：" prop="readCount">
          <el-input v-model="form.model.readCount" clearable/>
        </el-form-item>
        <el-form-item label="赞数：" prop="likeCount">
          <el-input v-model="form.model.likeCount" clearable/>
        </el-form-item>
      </el-col>
    </el-row>
  </nm-form-dialog>
</template>
<script>
import { mixins } from 'netmodular-ui'

const api = $api.blog.article

export default {
  mixins: [mixins.formDialogEdit],
  data () {
    return {
      api,
      form: {
        title: '编辑文章',
        action: api.update,
        model: {
          /** 标题 */
          title: '',
          /** 所属分类 */
          categoryId: '',
          /** 多媒体类型 */
          mediaType: '',
          /** 简介 */
          summary: '',
          /** 内容 */
          content: '',
          /** 私有的 */
          private: '',
          /** 已发布的 */
          published: '',
          /** 发布日期 */
          publishedTime: '',
          /** 阅读数 */
          readCount: '',
          /** 赞数 */
          likeCount: ''
        },
        rules: {
        }
      }
    }
  }
}
</script>
