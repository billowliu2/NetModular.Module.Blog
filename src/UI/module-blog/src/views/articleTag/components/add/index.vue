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
  mixins: [mixins.dialog],
  data () {
    return {
      form: {
        title: '添加文章标签列表',
        icon: 'add',
        action: api.add,
        model: {
          /** 文章编号 */
          articleId: '',
          /** 标签编号 */
          tagId: ''
        },
        rules: {
        }
      },
      on: {
        success: this.onSuccess,
        open: this.onOpen
      }
    }
  },
  methods: {
    onSuccess () {
      this.$emit('success')
    },
    onOpen () {
      this.$nextTick(() => {
        this.$refs.form.reset()
      })
    }
  }
}
</script>
