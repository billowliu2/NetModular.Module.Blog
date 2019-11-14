<template>
  <nm-form-dialog ref="form" v-bind="form" v-on="on" :visible.sync="visible_">
    <el-row>
      <el-col :span="20" :offset="1">
        <el-form-item label="文章编号：" prop="articleId">
          <el-input v-model="form.model.articleId" clearable/>
        </el-form-item>
        <el-form-item label="标签编号：" prop="tagId">
          <el-input v-model="form.model.tagId" clearable/>
        </el-form-item>
      </el-col>
    </el-row>
  </nm-form-dialog>
</template>
<script>
import { mixins } from 'netmodular-ui'

const api = $api.blog.articleTag

export default {
  mixins: [mixins.formDialogEdit],
  data () {
    return {
      api,
      form: {
        title: '编辑文章标签列表',
        action: api.update,
        model: {
          /** 文章编号 */
          articleId: '',
          /** 标签编号 */
          tagId: ''
        },
        rules: {
        }
      }
    }
  }
}
</script>
